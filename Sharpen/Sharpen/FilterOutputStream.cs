namespace Sharpen
{
    public class FilterOutputStream : OutputStream
    {
        protected OutputStream @out;

        public FilterOutputStream (OutputStream os)
        {
            this.@out = os;
        }

        public override void Close ()
        {
            this.@out.Close ();
        }

        public override void Flush ()
        {
            this.@out.Flush ();
        }

        public override void Write (sbyte[] b)
        {
            this.@out.Write (b);
        }

        public override void Write (int b)
        {
            this.@out.Write (b);
        }

        public override void Write (sbyte[] b, int offset, int len)
        {
            this.@out.Write (b, offset, len);
        }
    }
}
