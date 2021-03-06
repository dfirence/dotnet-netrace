//<autogenerated/>
using System;
using System.Diagnostics;
using System.Text;
using Address = System.UInt64;
// ReSharper disable All

#pragma warning disable 1591        // disable warnings on XML comments not being present

// This code was automatically generated by the TraceParserGen tool, which converts
// an ETW event manifest into strongly typed C# classes.
namespace Microsoft.Diagnostics.Tracing.Parsers
{
    using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftSystemNetRequests;

    [System.CodeDom.Compiler.GeneratedCode("traceparsergen", "2.0")]
    public sealed class MicrosoftSystemNetRequestsTraceEventParser : TraceEventParser 
    {
        public static string ProviderName = "Microsoft-System-Net-Requests";
        public static Guid ProviderGuid = new Guid(unchecked((int) 0x3763dc7e), unchecked((short) 0x7046), unchecked((short) 0x5576), 0x90, 0x41, 0x56, 0x16, 0xe2, 0x1c, 0xc2, 0xcf);
        public enum Keywords : long
        {
            Default = 0x1,
            Debug = 0x2,
            Enterexit = 0x4,
            Session3 = 0x100000000000,
            Session2 = 0x200000000000,
            Session1 = 0x400000000000,
            Session0 = 0x800000000000,
        };

        public MicrosoftSystemNetRequestsTraceEventParser(TraceEventSource source) : base(source) {}

        public event Action<AssociateArgs> Associate
        {
            add
            {
                source.RegisterEventTemplate(AssociateTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 3, ProviderGuid);
            }
        }
        public event Action<CriticalFailureArgs> CriticalFailure
        {
            add
            {
                source.RegisterEventTemplate(CriticalFailureTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 6, ProviderGuid);
            }
        }
        public event Action<EnterArgs> Enter
        {
            add
            {
                source.RegisterEventTemplate(EnterTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 1, ProviderGuid);
            }
        }
        public event Action<ErrorMessageArgs> ErrorMessage
        {
            add
            {
                source.RegisterEventTemplate(ErrorMessageTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 5, ProviderGuid);
            }
        }
        public event Action<EventSourceMessageArgs> EventSourceMessage
        {
            add
            {
                source.RegisterEventTemplate(EventSourceMessageTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 0, ProviderGuid);
            }
        }
        public event Action<ExitArgs> Exit
        {
            add
            {
                source.RegisterEventTemplate(ExitTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 2, ProviderGuid);
            }
        }
        public event Action<InfoArgs> Info
        {
            add
            {
                source.RegisterEventTemplate(InfoTemplate(value));
            }
            remove
            {
                source.UnregisterEventTemplate(value, 4, ProviderGuid);
            }
        }

        #region private
        protected override string GetProviderName() { return ProviderName; }

        static private AssociateArgs AssociateTemplate(Action<AssociateArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new AssociateArgs(action, 3, 65531, "Associate", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }
        static private CriticalFailureArgs CriticalFailureTemplate(Action<CriticalFailureArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new CriticalFailureArgs(action, 6, 65528, "CriticalFailure", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }
        static private EnterArgs EnterTemplate(Action<EnterArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new EnterArgs(action, 1, 65533, "Enter", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }
        static private ErrorMessageArgs ErrorMessageTemplate(Action<ErrorMessageArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new ErrorMessageArgs(action, 5, 65529, "ErrorMessage", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }
        static private EventSourceMessageArgs EventSourceMessageTemplate(Action<EventSourceMessageArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new EventSourceMessageArgs(action, 0, 65534, "EventSourceMessage", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }
        static private ExitArgs ExitTemplate(Action<ExitArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new ExitArgs(action, 2, 65532, "Exit", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }
        static private InfoArgs InfoTemplate(Action<InfoArgs> action)
        {                  // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
            return new InfoArgs(action, 4, 65530, "Info", Guid.Empty, 0, "", ProviderGuid, ProviderName );
        }

        static private volatile TraceEvent[] s_templates;
        protected override void EnumerateTemplates(Func<string, string, EventFilterResponse> eventsToObserve, Action<TraceEvent> callback)
        {
            if (s_templates == null)
            {
                var templates = new TraceEvent[7];
                templates[0] = EventSourceMessageTemplate(null);
                templates[1] = EnterTemplate(null);
                templates[2] = ExitTemplate(null);
                templates[3] = InfoTemplate(null);
                templates[4] = ErrorMessageTemplate(null);
                templates[5] = CriticalFailureTemplate(null);
                templates[6] = AssociateTemplate(null);
                s_templates = templates;
            }
            foreach (var template in s_templates)
                if (eventsToObserve == null || eventsToObserve(template.ProviderName, template.EventName) == EventFilterResponse.AcceptEvent)
                    callback(template);
        }

        #endregion
    }
}

namespace Microsoft.Diagnostics.Tracing.Parsers.MicrosoftSystemNetRequests
{
    public sealed class AssociateArgs : TraceEvent
    {
        public string thisOrContextObject { get { return GetUnicodeStringAt(0); } }
        public string memberName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string first { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }
        public string second { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))); } }

        #region Private
        internal AssociateArgs(Action<AssociateArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0))))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0))))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<AssociateArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "thisOrContextObject", thisOrContextObject);
             XmlAttrib(sb, "memberName", memberName);
             XmlAttrib(sb, "first", first);
             XmlAttrib(sb, "second", second);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "thisOrContextObject", "memberName", "first", "second"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return thisOrContextObject;
                case 1:
                    return memberName;
                case 2:
                    return first;
                case 3:
                    return second;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 1; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<AssociateArgs> m_target;
        #endregion
    }
    public sealed class CriticalFailureArgs : TraceEvent
    {
        public string thisOrContextObject { get { return GetUnicodeStringAt(0); } }
        public string memberName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string message { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal CriticalFailureArgs(Action<CriticalFailureArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<CriticalFailureArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "thisOrContextObject", thisOrContextObject);
             XmlAttrib(sb, "memberName", memberName);
             XmlAttrib(sb, "message", message);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "thisOrContextObject", "memberName", "message"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return thisOrContextObject;
                case 1:
                    return memberName;
                case 2:
                    return message;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 2; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<CriticalFailureArgs> m_target;
        #endregion
    }
    public sealed class EnterArgs : TraceEvent
    {
        public string thisOrContextObject { get { return GetUnicodeStringAt(0); } }
        public string memberName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string parameters { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal EnterArgs(Action<EnterArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<EnterArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "thisOrContextObject", thisOrContextObject);
             XmlAttrib(sb, "memberName", memberName);
             XmlAttrib(sb, "parameters", parameters);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "thisOrContextObject", "memberName", "parameters"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return thisOrContextObject;
                case 1:
                    return memberName;
                case 2:
                    return parameters;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 4; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<EnterArgs> m_target;
        #endregion
    }
    public sealed class ErrorMessageArgs : TraceEvent
    {
        public string thisOrContextObject { get { return GetUnicodeStringAt(0); } }
        public string memberName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string message { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal ErrorMessageArgs(Action<ErrorMessageArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<ErrorMessageArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "thisOrContextObject", thisOrContextObject);
             XmlAttrib(sb, "memberName", memberName);
             XmlAttrib(sb, "message", message);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "thisOrContextObject", "memberName", "message"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return thisOrContextObject;
                case 1:
                    return memberName;
                case 2:
                    return message;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 1; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<ErrorMessageArgs> m_target;
        #endregion
    }
    public sealed class EventSourceMessageArgs : TraceEvent
    {
        public string message { get { return GetUnicodeStringAt(0); } }

        #region Private
        internal EventSourceMessageArgs(Action<EventSourceMessageArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(0)));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(0)));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<EventSourceMessageArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "message", message);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "message"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return message;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 0; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<EventSourceMessageArgs> m_target;
        #endregion
    }
    public sealed class ExitArgs : TraceEvent
    {
        public string thisOrContextObject { get { return GetUnicodeStringAt(0); } }
        public string memberName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string result { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal ExitArgs(Action<ExitArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<ExitArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "thisOrContextObject", thisOrContextObject);
             XmlAttrib(sb, "memberName", memberName);
             XmlAttrib(sb, "result", result);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "thisOrContextObject", "memberName", "result"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return thisOrContextObject;
                case 1:
                    return memberName;
                case 2:
                    return result;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 4; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<ExitArgs> m_target;
        #endregion
    }
    public sealed class InfoArgs : TraceEvent
    {
        public string thisOrContextObject { get { return GetUnicodeStringAt(0); } }
        public string memberName { get { return GetUnicodeStringAt(SkipUnicodeString(0)); } }
        public string message { get { return GetUnicodeStringAt(SkipUnicodeString(SkipUnicodeString(0))); } }

        #region Private
        internal InfoArgs(Action<InfoArgs> target, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.m_target = target;
        }
        protected override void Dispatch()
        {
            m_target(this);
        }
        protected override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
            Debug.Assert(!(Version > 0 && EventDataLength < SkipUnicodeString(SkipUnicodeString(SkipUnicodeString(0)))));
        }
        protected override Delegate Target
        {
            get { return m_target; }
            set { m_target = (Action<InfoArgs>) value; }
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             XmlAttrib(sb, "thisOrContextObject", thisOrContextObject);
             XmlAttrib(sb, "memberName", memberName);
             XmlAttrib(sb, "message", message);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "thisOrContextObject", "memberName", "message"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return thisOrContextObject;
                case 1:
                    return memberName;
                case 2:
                    return message;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        public static ulong GetKeywords() { return 1; }
        public static string GetProviderName() { return "Microsoft-System-Net-Requests"; }
        public static Guid GetProviderGuid() { return new Guid("3763dc7e-7046-5576-9041-5616e21cc2cf"); }
        private event Action<InfoArgs> m_target;
        #endregion
    }
}
