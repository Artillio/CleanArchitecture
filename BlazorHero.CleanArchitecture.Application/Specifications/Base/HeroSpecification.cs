﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BlazorHero.CleanArchitecture.Domain.Contracts;

namespace BlazorHero.CleanArchitecture.Application.Specifications.Base
{
    public abstract class HeroSpecification<T, TId> : ISpecification<T, TId> where T : class, IEntity<TId>
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; } = new();
        public List<string> IncludeStrings { get; } = new();

        protected virtual void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}