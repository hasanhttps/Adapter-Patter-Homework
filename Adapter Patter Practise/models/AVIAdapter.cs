using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Patter_Practise.models {

    // Object Adapter
    public class AVIAdapter : AVI, IVideoRecorder {
        private AVI Avi;

        public AVIAdapter() { 
            Avi = new AVI();
        }

        public void Record() {
            Avi.RecordVideo();
        }
    }
}
