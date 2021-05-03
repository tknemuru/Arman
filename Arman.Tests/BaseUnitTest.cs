﻿using System.Collections.Generic;
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
            return $"../../../Resources/{this.GetType().Name}/{index.ToString().PadLeft(3, '0')}-{childIndex.ToString().PadLeft(3, '0')}-{type.ToString().ToLower()}.{extension}";
        }

        /// <summary>
        /// リソースを読み込みます。
        /// </summary>
        /// <returns>リソース</returns>
        /// <param name="index">インデックス</param>
        /// <param name="childIndex">子インデックス</param>
        /// <param name="type">リソース種別</param>
        /// <param name="extension">拡張子</param>
        protected IEnumerable<string> ReadResource(int index, int childIndex, ResourceType type, string extension = "txt")
        {
            var path = this.GetResourcePath(index, childIndex, type, extension);
            var lines = FileHelper.ReadTextLines(path);
            return lines;
        }
    }
}
