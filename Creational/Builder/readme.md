# Builder
## Creational Pattern

- Complex components inside a class or object
- The constructors take too much params
- Too much params is a code smell, more than three should be a warning
- Builder can help

## How does Builder work to solution problems?
- Builder will always be used when we're going to create complex objects
- We will break an object or a proccess in many other steps
- the __steps__ is a keyword
- A step can be a method
- We can thing about Builders as Robot constructors
- There is a __Director__ (another keyword)
- The Director will lead the builders