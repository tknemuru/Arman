using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arman.Helpers;

namespace Arman.Tests
{
    /// <summary>
    /// 基底ユニットテストクラス
    /// </summary>
    public abstract class BaseUnitTest
    {
        /// <summary>
        /// リソースのパスを取得します。
        /// </summary>
        /// <returns>リソースパス</returns>
        /// <param name="index">インデックス</param>
        /// <param name="childIndex">子インデックス</param>
        /// <param name="type">リソース種別</param>
        /// <param name="extension">拡張子</param>
        protected string GetResourcePath(int index, int childIndex, ResourceType type, string extension = "txt")
        {
            return $"../../../Resources/{this.GetType().Name}/{this.GetType().Name}-{index.ToString().PadLeft(3, '0')}-{childIndex.ToString().PadLeft(3, '0')}-{type.ToString().ToLower()}.{extension}";
        }

        /// <summary>
        /// リソースを読み込みます。
        /// </summary>
        /// <returns>リソース</returns>
        /// <param name="index">インデックス</param>
        /// <param name="childIndex">子インデックス</param>
        /// <param name="type">リソース種別</param>
        /// <param name="trim">空行を除くかどうか</param>
        protected IEnumerable<string> ReadResource(int index, int childIndex, ResourceType type, bool trim = true)
        {
            var path = this.GetResourcePath(index, childIndex, type);
            var lines = FileHelper.ReadTextLines(path)
                .Where(l => !trim || !string.IsNullOrWhiteSpace(l));
            return lines;
        }
    }
}
