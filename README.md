# coffee-app

# Issues
1.  Trying to find an online source to integrate the exchange rate microservice. This makes the microservice not work every once in a while
- I no longer feel like creating another integration to deal with this issue. For all intents and purposes, I assume a constant exchange rate until I start dealing with the Foreign exchange microservice as a priority. This is for me to focus on other issues.


# Microservice tasks

## Customer
1. Stores customers and the points they have

## CoffeeShop
1. Invoices
2.  Menue
3.  Orders
4. Stores currency in expiring cache

## GUI
1. Connects to Gateway

## ForeignCurrency
1. Gets currency conversions - Using the Service
2.  Expose them via API

## GateWay
1.  Connects to all microservices
2.  UI Connects to it only
