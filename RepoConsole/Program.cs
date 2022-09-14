
using console.efff.Models;
using Microsoft.Extensions.DependencyInjection;
using RepoConsole;
using Rrep.Core.InterFaces;

Console.WriteLine(StratUp<IRepo<Peron>>.Services().GetById(a=>a.Id==1).Name);
 