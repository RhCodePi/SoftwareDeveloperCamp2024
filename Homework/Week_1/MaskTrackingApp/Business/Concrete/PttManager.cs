﻿using Business.Abstract;
using Business.Adapters;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // if a person passes the mernis control system, then Ptt gives a mask to the person.
    public class PttManager<T> : BaseCustomManager
        where T : MernisServiceAdapter, new() 
    {
        private T instance; 

        public T Instance { 
            get {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance; 
            } 
        }

        public override void GiveMask(Person person)
        {
            if (Instance.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " applied for a mask and was accepted. ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " a person does not exist. ");
            }
        }
    }
}
