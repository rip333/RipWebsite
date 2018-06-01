using System;
using System.Collections.Generic;
using System.Text;

namespace PokefamCore.Models
{
    public class AbilityType
    {
        public TypeOf Type;
        public List<TypeOf> Double = new List<TypeOf>();
        public List<TypeOf> Half = new List<TypeOf>();
        public List<TypeOf> Zero = new List<TypeOf>();
    }
}
