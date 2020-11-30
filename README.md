# Builder Pattern v.s. Moq in Unit Tests

We regularly need to create some test data (or objects) for unit tests. A lot of unit tests only utilize a part of the input object, and disregard the rest properties of the data object. For example, a `Person` object contains name, gender, birth date, etc. , and we want to write a unit test to check the calculation of a person's age. We know that a person's age only depends on the current date and the person's birth date, and the person's other attributes do not matter in this specific unit test. Therefore, for testing purposes, it would be handy if we could quickly create simple `Person` objects with desired birth dates and ignore other properties.

If we are strict about immutable objects (for example, hiding public setters), then constructing objects in a desired state can be cumbersome. A common approach to set up test data is using the [Builder Pattern](https://en.wikipedia.org/wiki/Builder_pattern). We can adopt the Builder Pattern to write readable code. However, the Builder Pattern requires a ton of boilerplate code, and we also need to pay attention to the correctness of the builder classes. Is there an easy way to accomplish this job?

In this article, I will first show you how does the Builder Pattern work, then I will introduce you a simple way to stage the test data: using the famous `Moq` library.

## [Medium Article](https://codeburst.io/builder-pattern-and-moq-in-unit-tests-47281fa5b513)

![builder-pattern-vs-moq](./builder-pattern-vs-moq.png)
<sub><sup>Graphics Note: The builder icon is made by [Good Ware](https://www.flaticon.com/authors/good-ware) from [www.flaticon.com](https://www.flaticon.com/); The MOQ icon is from [its Git repository](https://github.com/moq/moq4).</sup></sub>
