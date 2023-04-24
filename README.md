# Bob's Bagels

![](./assets/bagels.webp)

## Learning Objectives
- Design a domain from user stories
- Use test driven development to build an application

## Set up instructions
- Fork this repository and clone the forked version to your machine
- Open the tdd-bobs-bagels.sln with Visual Studio

## Exercise Requirements

- Use only the Basket class and BasketTest class provided. Later, you'll be building another version of this project using multiple classes together as we learn object-oriented programming.
- You **must** design a domain model before you begin building. Add your model as either a `.md` file or a screenshot
- You **must** use the Red Green Refactor approach to write your code. To demonstrate this, `git commit` after writing your test and commit again after writing the source code to pass it

## User Stories

```
1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.
```

```
2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.
```

```
3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
```

```
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.
```

```
5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
```

![](./assets/run_test_single.png)

## Test Output

When you run a test, it's either going to pass or fail. When it fails, you'll be presented with a big red stream of text. This is called a stack trace and, though intimidating, does contain some useful information.

One of the core skills of a developer is debugging stack traces like this. The stack trace details in which classes & files the failure happened, and gives you a line number at the end. Most of the lines in the stack trace are irrelevant most of the time, you want to try and identify the files that you're actually working with.

In the sample screenshot below, we've tried to complete the first step of the exercise but provided an invalid value. Then we run the test associated with it and we see a big red stack trace, a test failure.

At the top, we see `expected: 512 but was: 0`. This means the test expected the value to be 512, but the value the student provided was 0.

In the stack trace itself, we see this line: `1.  at csharp_fundamentals_primitive_types.Test.CoreTests.twoShouldBe512() in C:\Dev\boolean\csharp\fundamentals\csharp-fundamentals-primitive-types\src\csharp-fundamentals-primitive-types.Test\CoreTests.cs:line 17`. This is helpful! This tells us the exact line in the `CoreTests.cs` file (line 17) where the failure happened, as well as the method name (twoShouldBe512), helping us to identify where the issue began. This is the kind of thing you need to look for; a relevant file name, method name, class name and line number to give you a good starting point for debugging.

![](./assets/test-failure.png)
