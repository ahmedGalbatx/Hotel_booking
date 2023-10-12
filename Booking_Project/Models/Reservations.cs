﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_Project.Models
{
    public enum Status
    {
        pending, confirmed, cancelled
    }
    public class Reservations
    {
        public Reservations()
        {
            reservationRooms = new List<ReservationRoom>();
        }
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime CheckInDate { get; set; }
        [Column(TypeName = "date")]

        public DateTime CheckOutDate { get; set; }
        [Column(TypeName = "Money")]
        public decimal TotalPrice { get; set; }
        [Column(TypeName = "varchar(20)")]
        public Status Status { get; set; }
        //  public string PaymentMethod { get; set; }   
        [ForeignKey("user")]
        public int UserId { get; set; }
        public User user { get; set; }
        public List<ReservationRoom> reservationRooms { get; set; }
        [ForeignKey("payments")]
        public int PaymentId { get; set; }
        public Payments payments { get; set; }
    }
}