namespace SolidPrinciples.DIP
{
    public class ResponseKind
    {
        public static ResponseKind HTML = new ResponseKind("html");
        
        private readonly string kind;

        private ResponseKind(string kind)
        {
            this.kind = kind;
        }

        public bool Equals(ResponseKind other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Equals(other.kind, kind);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof (ResponseKind))
                return false;
            return Equals((ResponseKind) obj);
        }

        public override int GetHashCode()
        {
            return (kind != null ? kind.GetHashCode() : 0);
        }

        public static bool operator ==(ResponseKind left, ResponseKind right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseKind left, ResponseKind right)
        {
            return !Equals(left, right);
        }
    }
}