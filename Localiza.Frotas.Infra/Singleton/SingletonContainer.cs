using System;
using System.Collections.Generic;
using System.Text;

namespace Localiza.Frotas.Infra.Singleton
{
    class SingletonContainer
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
