using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 这里的 namespace 其实可以不要，但是为了规范所以这里加上了 namespace
namespace EditorTools
{
    public class ProjBuild
    {
        // 实际项目中可以用更复杂的明明，例如项目名-日期-版本号
        private static string TargetPackageName = "Out.apk";
        // 其实方法名字也可以随便起，后面会手动指定调用的方法
        static void PerformBuild()
        {
            string[] scenes = { "Assets/Scenes/SampleScene.unity" };
            // 这里的"..."代表别的参数，例如目标平台、打包保存路径等，根据文档按照你的需要填入即可
            //BuildPipeline.BuildPlayer();
        }
    }
}
