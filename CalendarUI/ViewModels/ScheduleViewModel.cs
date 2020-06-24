using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using CalendarUI.Models;
using Xamarin.Essentials;

namespace CalendarUI.ViewModels
{
    public class ScheduleViewModel
    {
        public ObservableCollection<Schedule> schedule { get; set; }

        public ScheduleViewModel()
        {
            schedule = new ObservableCollection<Schedule>
            {
                new Schedule
                {
                     Title         = "Breakfast, Food and Cereal",
                     Description   = "Kefit, Yogurt, banana, apple, ...",
                     Hour          = "08:30 AM",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               Name = "Light",
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               Name = "Energised",
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          }, 
                          new Features
                          {
                               Name = "Satisfied",
                               BGColor = ColorConverters.FromHex("#fceeeb"),
                               TxColor = ColorConverters.FromHex("#fe4134")
                          },
                          new Features
                          {
                               Name = "Healthy",
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          },
                          new Features
                          {
                               Name = "Comfortable",
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          }
                      }
                },
                new Schedule
                {
                     Title         = "Lunch, Falafep wrap",
                     Description   = "Falafer, yoghurt, onions, tomatoes ...",
                     Hour          = "12:30 PM",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               Name = "Energised",
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          },
                          new Features
                          {
                               Name = "Light",
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               Name = "Satisfied",
                               BGColor = ColorConverters.FromHex("#fceeeb"),
                               TxColor = ColorConverters.FromHex("#fe4134")
                          },
                          new Features
                          {
                               Name = "Healthy",
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          },
                      }
                },
                new Schedule
                {
                     Title         = "Dinner, Bean chilli",
                     Description   = "Brown rice, Tomatoes, Kidney beans...",
                     Hour          = "08:30 PM",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               Name = "Light",
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               Name = "Satisfied",
                               BGColor = ColorConverters.FromHex("#fceeeb"),
                               TxColor = ColorConverters.FromHex("#fe4134")
                          }
                      }
                }
            };
        }
    }
}
