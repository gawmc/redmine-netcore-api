/*
   Copyright 2011 - 2017 Adrian Popescu.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System.Collections.Generic;

namespace RedmineApi.Core.Types
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class PaginatedResult<T>
    {
        public PaginatedResult()
        {
        }

        public PaginatedResult(List<T> items, int total, int offset) : this(items, total, offset, 0)
        {
        }

        public PaginatedResult(List<T> items, int total, int offset, int limit)
        {
            Items = items;
            Total = total;
            Offset = offset;
            Limit = limit;
        }

        /// <summary>
        /// </summary>
        public List<T> Items { get; set; }

        /// <summary>
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// </summary>
        public int Offset { get; set; }

        public int Limit { get; set; }

        public override string ToString()
        {
            return $"Total: {Total}, Offset: {Offset}, Limit: {Limit}";
        }
    }
}