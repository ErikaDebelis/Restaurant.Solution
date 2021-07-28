cuisines table
- id (int)
- name (string)

restaurants table
- name (string)
- location (string)
- hours (string e.g., 6am - 1am)
- expensiveness (int out of 5)
- rating (int out of 5)
- delivery (bool)
- cuisine_id (int)

### 3 different types of users (restaurant manager, customer, waiter, chef)
1. Restaurant manager
* update information - edit
* view sales
2. Customer
* browser menu
* select items from menu
* cart - all items they selected
3. Waiter
* view queue
* mark order picked
* view feedback
4. chef
* view queue
* accept
* update ready