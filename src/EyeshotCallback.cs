using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EyeshotWcfClientWinForms.EyeshotServiceRef;


namespace EyeshotWcfClientWinForms
{
    /// <summary>
    /// Utility class for the service's callback management.
    /// </summary>
    [CallbackBehavior(UseSynchronizationContext = false)]
    internal class EyeshotCallback : IEyeshotCallback
    {
        private readonly SynchronizationContext _syncContext = AsyncOperationManager.SynchronizationContext;
        public event EventHandler<OnProgressChangedEventArgs> ServiceOnProgressChangedEvent;
        public event EventHandler<OnOperationCompletedEventArgs> ServiceOnOperationCompletedEvent;
        public event EventHandler<OnTransformationCompletedEventArgs> ServiceOnTransformationCompletedEvent;

        #region OnOperationCompleted                
        public void OnOperationCompleted(OperationsType operationType, int resultsCount, string log, bool skipped)
        {
            _syncContext.Post(new SendOrPostCallback(OnOperationCompletedEvent), new OnOperationCompletedEventArgs(operationType, resultsCount, log, skipped));
        }

        public IAsyncResult BeginOnOperationCompleted(OperationsType operationType, int resultsCount, string log, bool skipped, AsyncCallback callback,
            object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndOnOperationCompleted(IAsyncResult result)
        {
            throw new NotImplementedException();
        }        

        private void OnOperationCompletedEvent(object state)
        {
            EventHandler<OnOperationCompletedEventArgs> handler = ServiceOnOperationCompletedEvent;
            OnOperationCompletedEventArgs e = state as OnOperationCompletedEventArgs;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion        

        #region OnTransformationCompleted                
        public void OnTransformationCompleted(TransformationsType transformationType, string log, bool skipped)
        {
            _syncContext.Post(new SendOrPostCallback(OnTransformationCompletedEvent), new OnTransformationCompletedEventArgs(transformationType, log, skipped));
        }

        public IAsyncResult BeginOnTransformationCompleted(TransformationsType transformationType, string log, bool skipped, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }        

        public void EndOnTransformationCompleted(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        private void OnTransformationCompletedEvent(object state)
        {
            EventHandler<OnTransformationCompletedEventArgs> handler = ServiceOnTransformationCompletedEvent;
            OnTransformationCompletedEventArgs e = state as OnTransformationCompletedEventArgs;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion        

        #region OnProgressChanged                      
        public void OnProgressChanged(string msg, int percent)
        {
            _syncContext.Post(new SendOrPostCallback(OnServiceProgressChangedEvent), new OnProgressChangedEventArgs(msg, percent));
        }

        public IAsyncResult BeginOnProgressChanged(string msg, int percent, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndOnProgressChanged(IAsyncResult result)
        {
            throw new NotImplementedException();
        }        

        private void OnServiceProgressChangedEvent(object state)
        {
            EventHandler<OnProgressChangedEventArgs> handler = ServiceOnProgressChangedEvent;
            OnProgressChangedEventArgs e = state as OnProgressChangedEventArgs;            

            if (handler != null)
            {
                handler(this, e);
            }
        }        
        #endregion
    }

    internal class OnProgressChangedEventArgs : EventArgs
    {
        /// <summary>
        /// The message.
        /// </summary>
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        

        /// <summary>
        /// A value representing the current operation's progress in the range [0-100].
        /// </summary>
        private int _percent;

        public int Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }
        


        public OnProgressChangedEventArgs(string msg, int percent)
        {
            _message = msg;
            _percent = percent;
        }
    }

    internal class OnTaskCompletedEventArgs : EventArgs
    {
        private string _log;
        /// <summary>
        /// Gets the log of the operation.
        /// </summary>
        public string Log
        {
            get { return _log; }
        }

        private bool _skipped;
        /// <summary>
        /// True when the operation was skipped because of errors occurred (see <see cref="Log"/> for details).
        /// </summary>
        public bool Skipped
        {
            get { return _skipped; }
        }

        public OnTaskCompletedEventArgs(string log, bool skipped)
        {        
            _log = log;
            _skipped = skipped;
        }
    }

    internal class OnOperationCompletedEventArgs : OnTaskCompletedEventArgs
    {
        private OperationsType _operationType;
        /// <summary>
        /// Gets the operation type.
        /// </summary>
        public OperationsType OperationType
        {
            get { return _operationType; }
        }

        private int _resultsCount;
        /// <summary>
        /// Gets how many files have been produced by this operation and are ready for the download.
        /// </summary>
        public int ResultsCount
        {
            get { return _resultsCount; }            
        }
                        

        public OnOperationCompletedEventArgs(OperationsType operationType, int count, string log, bool skipped) : base (log, skipped)
        {
            _operationType = operationType;
            _resultsCount = count;           
        }
    }

    internal class OnTransformationCompletedEventArgs : OnTaskCompletedEventArgs
    {
        private TransformationsType _transformationType;
        /// <summary>
        /// Gets the Transformation type.
        /// </summary>
        public TransformationsType TransformationType
        {
            get { return _transformationType; }
        }       

        public OnTransformationCompletedEventArgs(TransformationsType transformationType, string log, bool skipped) : base(log, skipped)
        {
            _transformationType = transformationType;            
        }
    }
}
