using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        private IEnumerable<ICondition> conditions;

        public PasswordCheckerService(IRepository repository, IEnumerable<ICondition> conditions)
        {
            this.repository = repository;
            this.conditions = conditions;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            var result = conditions.Select(x => x.IsValid(password));
            if(result.All(x => x.Item1))
            {
                repository.Create(password);
                return Tuple.Create(true, "Good password");
            }

            return result.First(x => !x.Item1);
        }
    }
}
