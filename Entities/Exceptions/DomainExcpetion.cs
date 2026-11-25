namespace EstudoEmCSharp.Entities.Exceptions
{
    internal class DomainExcpetion : ApplicationException
    {
        public DomainExcpetion(string mensage) : base(mensage) { }
    }
}
