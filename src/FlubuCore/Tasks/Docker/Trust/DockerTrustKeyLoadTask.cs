
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Trust
{
     public partial class DockerTrustKeyLoadTask : ExternalProcessTaskBase<int, DockerTrustKeyLoadTask>
     {
        private string _keyfile;

        
        public DockerTrustKeyLoadTask(string keyfile)
        {
            ExecutablePath = "docker";
            WithArguments("trust key load");
_keyfile = keyfile;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name for the loaded key
        /// </summary>
        [ArgKey("--name")]
        public DockerTrustKeyLoadTask Name(string name)
        {
            WithArgumentsKeyFromAttribute(name.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_keyfile);

            return base.DoExecute(context);
        }

     }
}