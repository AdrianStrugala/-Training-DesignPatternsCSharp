using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Chain
    {
        private readonly List<IJob> _jobs;

        public Chain(List<IJob> jobs)
        {
            this._jobs = jobs;
        }

        public void Start(object context)
        {
            foreach (IJob job in _jobs)
            {
                bool success = job.Run(context);

                if (!success)
                {
                    return;
                }
            }
        }
    }
}
