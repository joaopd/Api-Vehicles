using Domain.Enums;
using Domain.ValueObject;
using System.Text.RegularExpressions;

namespace Domain.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public OwnerStatusEnum Status { get; private set; }
        public Address Address { get; private set; }

        private Owner() { }

        public Owner(string name, OwnerStatusEnum status, Address address)
        {
            Name = name;

            Status = status;
            Address = address;
        }
        public bool DocumentValid(string document)
        {
            if (document.Length == 11)
                return new Cpf(document).EhValido;

            return new Cnpj(document).EhValido;
        }

        public bool EmailValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }

        public void SetAddress(Address address)
        {
            Address = address;
        }
        public void SetDocument(string document)
        {
            Document = document;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetStatus(OwnerStatusEnum status)
        {
            Status = status;
        }
    }
}
