# Josephus Problem

Intermediate level task for practicing algorithms and iterator methods.

Estimated time to complete the task - 1h.

The task requires .NET 6 SDK installed.


## Task Description

One of the talents that [Josephus Flavius](https://en.wikipedia.org/wiki/Josephus_problem) possessed was the mathematical skill, which according to legend saved his life. When the Romans trapped 40 of Flavius's followers and him, they made a death pact in which the Romans would not get them, they rather be dead. They took deadly counts in a circle of soldiers. Each third was killed. The count continued until one man was left. It was man who took 31st place in that circle. Yes, It was Flavius. He had another opinion about life, death and his special assignment in this war. Below you see the tool, which can calculate for you any amount of numbers for any picked out number and for any number left (less than total, of course). Just remember, Flavius quickly solved such a problem in his head without any computer program. Hopefully you will never be at needs to use this tool for saving your life but maybe you'll find another reason to use it.

There are `n` people in the circle, numbered from `1` to `n`. When keeping the account in a circle, every `k`-th person is "crossed out" until one is left.

* Implement the [GetCrossedOutPersons](JosephusProblem/JosephusFlavius.cs#L20) method to return an *iterator* that generates a list of persons that are crossed out. Use [yield return statement](https://docs.microsoft.com/en-us/dotnet/csharp/iterators) to define an iterator method.
* Implement the [GetSurvivor](JosephusProblem/JosephusFlavius.cs#L33) method to return a survivor position number.
