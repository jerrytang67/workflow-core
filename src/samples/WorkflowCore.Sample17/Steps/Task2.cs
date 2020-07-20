﻿using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.Sample17.Steps
{
    public class Task2 : StepBody
    { 
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Doing Task 2");
            return ExecutionResult.Next();

            throw new Exception();
        }
    }
}
