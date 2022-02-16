# Cupcake Kata C#

C# implementation of the [Cupcake Kata](https://codingdojo.org/kata/cupcake/).

## About this kata

This kata was originaly made to implement the decorator and composit pattern.

## Problem Description

Write a program that can build many cake with many toppings like : “Cupcake with chocolate and nuts” Or “🧁 with black 🍫 and 🥜 and 🍬”. Be carful the order of topping is very important.

Write a function or method they can show the name of cake.

Write a function they can show the price of cake. The price is composed from base cake price and topping price.

## Bundle of non fresh cakes

Now it’s possible to make a bundle of cakes. The price of a bundle is 10% less than prices of each cakes.

It’s possible to build a bundle of bundle with singles cakes.

## Suggested Test Cases

### Decorator pattern

In pseudo code to build a Cupcake with chocolate and nuts and sugar you will write

```C#
var myCake = Sugar(Nuts(Chocolate(Cupcake())))
```

With typing, we can start to test : * I can put a Cupcake in a variable of type Cake

### About name function or method

-   The name function should return “🧁”
-   The name function should return “🍪”
-   The name function should return “🧁 with 🍫”
-   The name function should return “🍪 with 🍫”
-   The name function should return “🍪 with 🍫 and 🥜”
-   The name function should return “🍪 with 🥜 and 🍫”

### About price function or method

-   The price function should return 1$ for “🧁”
-   The price function should return 2$ for “🍪”
-   The price function should return 1.1$ for “🧁 with 🍫”
-   The price function should return 2.1$ for “🍪 with 🍫”
-   The price function should return 2.2$ for “🍪 with 🥜”

### Bundle

-   We can build a Bundle with 1 Cupcake and check price or description
-   We can build a Bundle with 1 Cupcake and 1 Cookie and check price or description
-   We can build a Bundle with 2 Cupcake and 1 Cookie and check price or description
-   We can build a bundle with 1 bundle of 2 cakes and 1 Cupcake and check price or description
-   We can build a bundle with many bundle of bundle and many cakes and check price or description