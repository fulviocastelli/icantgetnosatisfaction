﻿using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

using System;
using System.IO;
using System.Collections.Generic;

namespace Assets.Editor
{
    public static class PostBuild
    {
        [PostProcessBuild]
        static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
        {
            string path = Path.GetDirectoryName(pathToBuiltProject) + "/" + Path.GetFileNameWithoutExtension(pathToBuiltProject) + "_Data";
            FileUtil.CopyFileOrDirectory("Assets/Data", path + "/Data");
        }
    }
}
