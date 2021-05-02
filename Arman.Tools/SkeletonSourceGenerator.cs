using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arman.Helpers;

namespace Arman.Tools
{
    /// <summary>
    /// スケルトンソースの生成機能を提供します。
    /// </summary>
    public class SkeletonSourceGenerator
    {
        /// <summary>
        /// ルートディレクトリ
        /// </summary>
        private const string RootDir = "/opt/Arman";

        /// <summary>
        /// スケルトンソースを生成します。
        /// </summary>
        /// <param name="url">URL</param>
        public void Execute(String url)
        {
            var rootId = url.Split('/')[4];
            var ids = url.Split('/').Last().Split('_');
            var idKey = ids[0] == rootId ? ids[0] : $"{rootId}{ids[0].Substring(0, 1).ToUpper()}{ids[0].Substring(1)}";
            var idLevel = ids[1];
            var upperId = $"{idKey.Substring(0, 1).ToUpper()}{idKey.Substring(1)}{idLevel.ToUpper()}";
            Func<string, string> replaceTemplate = (string l) =>
            {
                var r = l
                        .Replace("abc999", idKey)
                        .Replace("XXX", idLevel)
                        .Replace("AbcTemplate", upperId)
                        .Replace("https", url);
                return r;
            };
            var templateLines = FileHelper.ReadTextLines($"{RootDir}/Arman/Questions/AbcTemplate.cs");
            var replacedTemplates = templateLines.Select(l => replaceTemplate(l));
            var templateTestLines = FileHelper.ReadTextLines($"{RootDir}/Arman.Tests/Questions/AbcTemplateTest.cs");
            var replacedTestTemplates = templateTestLines.Select(l => replaceTemplate(l));
            var append = false;
            var path = $"{RootDir}/Arman/Questions/{upperId}.cs";
            foreach (var l in replacedTemplates)
            {
                FileHelper.WriteLine(l, path, append);
                append = true;
            }
            append = false;
            path = $"{RootDir}/Arman.Tests/Questions/{upperId}Test.cs";
            foreach (var l in replacedTestTemplates)
            {
                FileHelper.WriteLine(l, path, append);
                append = true;
            }
        }
    }
}
