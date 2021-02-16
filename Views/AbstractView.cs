using System;

namespace Views
{
  public abstract class AbstractView : IView
  {
    public abstract UserOption ShowView();
  }

}