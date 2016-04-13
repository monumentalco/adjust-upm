﻿using System;

namespace com.adjust.sdk
{
    public class AdjustConfig
    {
        #region Fields
        internal string appToken;
        internal string sceneName;
        internal string defaultTracker;

        internal bool? eventBufferingEnabled;

        internal AdjustLogLevel? logLevel;
        internal AdjustEnvironment environment;

        internal Action<AdjustEventSuccess> eventSuccessDelegate;
        internal Action<AdjustEventFailure> eventFailureDelegate;
        internal Action<AdjustSessionSuccess> sessionSuccessDelegate;
        internal Action<AdjustSessionFailure> sessionFailureDelegate;
        internal Action<AdjustAttribution> attributionChangedDelegate;

        // Android specific members
        internal string processName;

        // Windows specific members
        internal Action<String> logDelegate;
        #endregion

        #region Constructors
        public AdjustConfig (string appToken, AdjustEnvironment environment)
        {
            this.sceneName = "";
            this.processName = "";
            this.appToken = appToken;
            this.environment = environment;
        }
        #endregion

        #region Public methods
        public void setLogLevel (AdjustLogLevel logLevel)
        {
            this.logLevel = logLevel;
        }

        public void setDefaultTracker (string defaultTracker)
        {
            this.defaultTracker = defaultTracker;
        }

        public void setEventBufferingEnabled (bool eventBufferingEnabled)
        {
            this.eventBufferingEnabled = eventBufferingEnabled;
        }

        public void setAttributionChangedDelegate (Action<AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust")
        {
            this.attributionChangedDelegate = attributionChangedDelegate;
            this.sceneName = sceneName;
        }

        public Action<AdjustAttribution> getAttributionChangedDelegate ()
        {
            return this.attributionChangedDelegate;
        }

        public void setEventSuccessDelegate (Action<AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust")
        {
            this.eventSuccessDelegate = eventSuccessDelegate;
            this.sceneName = sceneName;
        }

        public Action<AdjustEventSuccess> getEventSuccessDelegate ()
        {
            return this.eventSuccessDelegate;
        }

        public void setEventFailureDelegate (Action<AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust")
        {
            this.eventFailureDelegate = eventFailureDelegate;
            this.sceneName = sceneName;
        }

        public Action<AdjustEventFailure> getEventFailureDelegate ()
        {
            return this.eventFailureDelegate;
        }

        public void setSessionSuccessDelegate (Action<AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust")
        {
            this.sessionSuccessDelegate = sessionSuccessDelegate;
            this.sceneName = sceneName;
        }

        public Action<AdjustSessionSuccess> getSessionSuccessDelegate ()
        {
            return this.sessionSuccessDelegate;
        }

        public void setSessionFailureDelegate (Action<AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust")
        {
            this.sessionFailureDelegate = sessionFailureDelegate;
            this.sceneName = sceneName;
        }

        public Action<AdjustSessionFailure> getSessionFailureDelegate ()
        {
            return this.sessionFailureDelegate;
        }

        // Android specific methods.
        public void setProcessName (string processName)
        {
            this.processName = processName;
        }

        // Windows specific methods.
        public void setLogDelegate(Action<String> logDelegate)
        {
            this.logDelegate = logDelegate;
        }
        #endregion
    }
}