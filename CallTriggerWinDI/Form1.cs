using MyPhonePlugins;
using TCX.CallTriggerCmd;

namespace CallTriggerWinDI {
    public partial class Form1 : Form {
        private readonly IMyPhoneCallHandler callHandler;
        public Form1(IMyPhoneCallHandler callHandler) {
            this.callHandler = callHandler;
            CallTriggerCmdPluginLoader.Loader(callHandler);
            InitializeComponent();
        }

        private void buttonPause_Click(object sender, EventArgs e) {
            callHandler.SetQueueLoginStatus(true);
        }
    }
}