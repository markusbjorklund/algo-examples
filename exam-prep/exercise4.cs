using System;
using System.Collections.Generic;

namespace examprep
{
  class Flights
  {
    public void AddConnection(string departure, string destination, int price)
    {
      // The method AddConnection adds a connection between cities departure and destination, with the price of price.
    }

    public int RoutePrice(string departure, string destination)
    {
      return 0;
      // The method RoutePrice returns the best price from city departure to the city destination (or -1 if there is no such route).
    }
  }
}