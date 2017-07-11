﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using CatLib.Debugger.WebConsole;
using CatLib.Stl;
using System;
using System.Collections.Generic;

namespace CatLib.Debugger.WebLog.Protocol
{
    /// <summary>
    /// 获取分组API
    /// </summary>
    internal sealed class GetLogCatergroy : IWebConsoleResponse
    {
        /// <summary>
        /// 响应
        /// </summary>
        public object Response
        {
            get { return outputs; }
        }

        /// <summary>
        /// 输出
        /// </summary>
        private readonly IDictionary<string, string> outputs;

        /// <summary>
        /// 获取分组API
        /// </summary>
        public GetLogCatergroy()
        {
            outputs = new Dictionary<string, string>();
        }

        /// <summary>
        /// 获取分组接口
        /// </summary>
        /// <param name="dict"></param>
        public GetLogCatergroy(IDictionary<string, string> dict)
        {
            Guard.Requires<ArgumentNullException>(dict != null);
            outputs = dict;
        }

        /// <summary>
        /// 写入一条分组信息
        /// </summary>
        /// <param name="namespace">命名空间</param>
        /// <param name="categroyName">分组名</param>
        public void WriteLine(string @namespace, string categroyName)
        {
            outputs[@namespace] = categroyName;
        }
    }
}
