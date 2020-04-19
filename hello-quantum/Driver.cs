﻿using System.Threading.Tasks;
using Microsoft.Quantum.Simulation.Simulators;

namespace Untitled
{
    class Driver
    {
        static async Task Main(string[] args)
        {
            using var qsim = new QuantumSimulator();
            await HelloQ.Run(qsim);
        }
    }
}