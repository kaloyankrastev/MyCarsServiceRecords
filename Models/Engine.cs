using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarsServiceRecords.Models
{
    /// <summary>
    /// Represents a car engine
    /// </summary>
    public struct Engine
    {
        /// <summary>
        /// Type of the engine
        /// </summary>
        public EngineType Type { get; }

        /// <summary>
        /// Production code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Displacement of the engine in cm^3
        /// </summary>
        public string Displacement { get; }

        /// <summary>
        /// Engine power in KW
        /// </summary>
        public int Power { get; }

        /// <summary>
        /// Engine number
        /// </summary>
        public string Number { get; }

        /// <summary>
        /// Initalizes an engine object
        /// </summary>
        /// <param name="type">Type of the engine</param>
        /// <param name="code">Engine production code</param>
        /// <param name="displacement">Engine displacement in cm^3</param>
        /// <param name="power">Engine power</param>
        /// <param name="number">Engine number</param>
        public Engine(EngineType type, string code, string displacement, int power, string number)
        {
            Type = type;
            Code = code;
            Displacement = displacement;
            Power = power;
            Number = number;
        }
    }
}
