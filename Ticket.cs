﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ticket
{
    public virtual Int DepartureID
    {
        get;
        set;
    }

    public virtual Int DestinationID
    {
        get;
        set;
    }

    public virtual Date TravelDate
    {
        get;
        set;
    }

    public virtual TripType TripType
    {
        get;
        set;
    }

    public virtual DiscountType Discount
    {
        get;
        set;
    }

    public virtual TripType TripType
    {
        get;
        set;
    }

    public virtual DiscountType DiscountTypes
    {
        get;
        set;
    }

    public virtual double calculatePrice()
    {
        throw new System.NotImplementedException();
    }

}

