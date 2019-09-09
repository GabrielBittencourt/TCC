using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Affdex.Detector detector = new Affdex.CameraDetector(0, 30, 30, 3, Affdex.FaceDetectorMode.LARGE_FACES);
            Form1 feed = new Form1(detector);
            detector.setClassifierPath("E:\\Ufpel\\TCC\\APIs\\AffdexSDK\\data");
            detector.setDetectAllEmotions(true);
            detector.setDetectAllEmojis(true);
            detector.start();
            feed.ShowDialog();
            detector.stop();
        }
    }
}
