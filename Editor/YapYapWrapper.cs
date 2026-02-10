using Nomnom.UnityProjectPatcher.Editor;
using Nomnom.UnityProjectPatcher.Editor.Steps;

namespace Kesomannen.YapYapProjectPatcher.Editor {
    [UPPatcher("com.kesomannen.unity-yapyap-project-patcher")]
    public static class YapYapWrapper {
        public static void GetSteps(StepPipeline stepPipeline) {
            stepPipeline.SetInputSystem(InputSystemType.Both);
            stepPipeline.SetGameViewResolution("16:9");
            
            stepPipeline.OpenSceneAtEnd("Bootstrap");
            
            stepPipeline.InsertLast(new FixES3Step());
            
        }
    }
}
