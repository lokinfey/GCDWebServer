using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using UIKit;

//using WebUploadApp.Binding;

namespace WebUploadApp
{
    public partial class ViewController : UIViewController
    {
         //GCDWebUploader up;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            bool status = true;

            foreach (var netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (var addrInfo in netInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (addrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            
                            var ipAddress = addrInfo.Address;

                            this.lbStatus.Text = "Use pc to access  http://" + ipAddress+":8080";

                            status = false;

                            break;

                        }
                    }

                    if (!status)
                        break;
                }
            }



           // var temp = 1;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
