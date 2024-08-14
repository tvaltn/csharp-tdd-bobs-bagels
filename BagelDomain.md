# Bobs Bagels Domains

Will drop the inclusion of classes since we are only using the Basket class for all of the domains,
as this was included in the exercise requirements.

### User story 1
1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

| Members                           | Methods                       | Scenario                  | Output    |
|-----------------------------------|-------------------------------|---------------------------|-----------|
| `Dictionary<string, int> items`   | `add(string bagel, int price)`| bagel got added to basket | true      |
|                                   |                               | bagel did not get added   | false     |


### User story 2
2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

| Members                           | Methods                | Scenario                      | Output    |
|-----------------------------------|------------------------|-------------------------------|-----------|
| `Dictionary<string, int> items`   | `remove(string bagel)` | bagel got removed from basket | true      |
|                                   |                        | bagel did not get removed     | false     |


### User story 3
3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

Here I am assuming that the member of the public just wants to know if the basket is full.
The thought process would be that the member will first check if the basket is full, with the intention of
wanting to add an item to the basket, and then adding the item to the basket afterwards if there is space.

| Members                           | Methods              | Scenario                  | Output    |
|-----------------------------------|----------------------|---------------------------|-----------|
| `Dictionary<string, int> items`   | `isFull()`           | basket is full            | true      |
| `int capacity`                    |                      | basket is not full        | false     |


### User story 4
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Members                           | Methods                   | Scenario                     | Output    |
|-----------------------------------|---------------------------|------------------------------|-----------|
| `Dictionary<string, int> items`   | `changeCapacity(int size)`| capacity got changed         | true      |
| `int capacity`                    |                           | capacity did not get changed | false     |


### User story 5
5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

In this user story I am assuming that the member of the public wants to simply know if the item
does not exist in the basket. **Not** that they want to be in the act of removing an item, and then
knowing if the item did not exist in the basket.

| Members                           | Methods              | Scenario                  | Output    |
|-----------------------------------|----------------------|---------------------------|-----------|
| `Dictionary<string, int> items`   | `exists(string item)`| item exists in basket     | true      |
|                                   |                      | item does not exist       | false     |