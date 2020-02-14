using System;
using System.Reflection;

namespace DaanV2.Data {
    internal partial class DataConnections {
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MethodInfo[] DataCreate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MethodInfo[] DataValidate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MethodInfo[] DataDestroy { get; set; }
    }
}
