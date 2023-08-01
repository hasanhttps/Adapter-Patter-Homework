using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Patter_Practise.models {
    public class Main {
        public void main() {
            List<IVideoRecorder> videoRecorders = new List<IVideoRecorder>() {
                new MP4(),
                new MOV(),
                new AVIAdapter()
            };
        }
    }
}
