using CSDeskBand.ContextMenu;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWinforms
{
    [ComVisible(true)]
    [Guid("FB17B6DA-E3D7-4D17-9E43-3416983372A9")]
    [CSDeskBand.CSDeskBandRegistration(Name = "Focus Window", ShowDeskBand = false)]
    public class FocusTimer : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;
        private CancellationTokenSource cancellationSource;
        private int defaultTimerMinutes = 25;
        private int minutesLeft;
        private readonly string clockIcon = Encoding.UTF8.GetString(new byte[] { 0xF0, 0x9F, 0x95, 0x91 });
        private readonly List<int> timeWindows = new List<int>{0, 5, 10, 15, 20, 25, 30};

        public FocusTimer()
        {
            Options.ShowTitle = true;
            this.Options.ContextMenuItems = ContextMenuItems;
            _control = new UserControl1(this);
            this.Options.Title = $"{clockIcon}";
        }

        private async Task RunTimer()
        {
            minutesLeft = defaultTimerMinutes;
            cancellationSource = new CancellationTokenSource();
            while (!cancellationSource.IsCancellationRequested && minutesLeft != 0)
            {
                this.Options.Title = $"{clockIcon} { minutesLeft.ToString()}";
                --minutesLeft;
                await Task.Delay(60000, cancellationSource.Token);
            }
            this.Options.Title = $"{clockIcon}";
            CalloutTimerExpiryToUser();
        }

        protected override Control Control => _control;

        public void CalloutTimerExpiryToUser()
        {
            this.Control.Hide();

            if (defaultTimerMinutes != 0)
            {
                MessageBox.Show(
                        $"I can do this all day..",
                        $"You've spent {defaultTimerMinutes} minutes.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        public void CalloutUserTriggeredStopMessage()
        {
            MessageBox.Show(
                    $"Quittin' already?",
                    $"Timer stopped.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
        
        private List<DeskBandMenuItem> ContextMenuItems
        {
            get
            {
                List<DeskBandMenuItem>  menuItems = new List<DeskBandMenuItem>();
                foreach (int timeWindow in timeWindows)
                {
                    menuItems.Add(CreateSubMenuAction(timeWindow));
                }
                return menuItems;
            }
        }

        private DeskBandMenuAction CreateSubMenuAction(int timeWindowInMinutes)
        {
            string actionName = timeWindowInMinutes != 0 ? $"{timeWindowInMinutes} minutes" : "Stop";
            DeskBandMenuAction submenuAction = new DeskBandMenuAction(actionName);

            submenuAction.Clicked += (sender, args) => {
                minutesLeft = defaultTimerMinutes = timeWindowInMinutes;

                this.Options.Title = $"{clockIcon}";
                if (timeWindowInMinutes != 0)
                {
                    this.Options.Title += $" {timeWindowInMinutes}";
                }
                else
                {
                    Task.Run(() => CalloutUserTriggeredStopMessage());
                }

                if (cancellationSource != null)
                {
                    cancellationSource.Cancel();
                }

                Task.Run(() => RunTimer());
            };

            return submenuAction;
        }
    }
}
