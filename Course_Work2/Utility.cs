using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course_Work2
{
    class Utility
    {
        public static int Get_Period(Temp temp)
        {
            int period;
            period = Int32.Parse(((temp.DateOUT.Date - temp.DateIN.Date).TotalDays).ToString());
            return period;
        }

        public static bool Date_Compare(Room current_room, DateTime DateIN, DateTime DateOUT) // check if dates intersect false-intersect
        {
            if (current_room.Records != null)
            {
                for (int i = 0; i < current_room.Records.Count; i++)
                {
                    if ((DateTime.ParseExact(current_room.Records[i].Date_IN, ("dd.MM.yyyy"), CultureInfo.InvariantCulture) > DateOUT) ||
                       (DateTime.ParseExact(current_room.Records[i].Date_OUT, ("dd.MM.yyyy"), CultureInfo.InvariantCulture) < DateIN))
                    {
                        continue;
                    }
                    else return false;
                }
                return true;
            }
            return false;
        }

        public static bool Check_for_RoomNumber(Room current_room, Temp temp)
        {
            if ((String.Compare(current_room.Amount_of_rooms, (temp.AmountOfRooms).ToString(), true) == 0) &&
                (String.Compare(current_room.Type, (temp.RoomType).ToString(), true) == 0) &&
                Int32.Parse(current_room.Amount_of_persons) >= Int32.Parse((temp.AmountOfPersons).ToString()))
            {
                return true;
            }
            else return false;
        }
        public static bool Check_fields(Temp temp)
        {
            if ((temp.AmountOfPersons == null 
                || (temp.RoomType == null && temp.AmountOfRooms != null)
                || (temp.RoomType != null && temp.AmountOfRooms == null)))
            {
                return false;
            }
            else return true;
        }

            public static bool Check_for_RoomNumber_with_gender(Room current_room, Temp temp, string gender)
        {
            int index = 0;
            int amount_by_day = Int32.Parse(temp.AmountOfPersons.ToString());
            int period = Utility.Get_Period(temp);
            for (int i = 0; i <= period; i++)
            {
                foreach (var item in current_room.Records)
                {
                    if ((DateTime.ParseExact(current_room.Records[index].Date_IN, ("dd.MM.yyyy"), CultureInfo.InvariantCulture) <= temp.DateIN.Date.AddDays(i)) &&
                          (DateTime.ParseExact(current_room.Records[index].Date_OUT, ("dd.MM.yyyy"), CultureInfo.InvariantCulture) >= temp.DateIN.Date.AddDays(i)))
                    {
                        amount_by_day += Int32.Parse(current_room.Records[index].Amount_of_persons_reserved);

                        if (amount_by_day > Int32.Parse(current_room.Amount_of_persons) || current_room.Records[index].Gender != gender)
                        {
                            return false;
                        }
                    }
                    index++;
                }
                amount_by_day = Int32.Parse(temp.AmountOfPersons.ToString());
                index = 0;
            }
            return true;
        }

        public static bool Check_for_RoomNumber_only_by_date (Room current_room, string gender, Temp temp)
        {
            if (Int32.Parse(current_room.Amount_of_persons) >= Int32.Parse((temp.AmountOfPersons).ToString()))
            {
                if (Check_for_RoomNumber_with_gender(current_room, temp, gender))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public static int Get_Prise(Temp temp, string gender, List<Room> rooms)
        {
            int period = Utility.Get_Period(temp);
            int prise;
            var item = rooms.Find(x => String.Compare(x.Number, (temp.RoomNumber).ToString(), true) == 0);
            if (temp.RoomType.ToString() == "Vip" || temp.RoomType.ToString() == "President")
            {
                prise = period * Int32.Parse(item.Price.ToString());
            }
            else if (gender == "family")
            {
                prise = Int32.Parse(item.Amount_of_persons.ToString()) * period * Int32.Parse(item.Price.ToString());
            }
            else prise = Int32.Parse(temp.AmountOfPersons.ToString()) * period * Int32.Parse(item.Price.ToString());

            return prise;
        }

        public static bool Date_Are_Equal(Record record, Temp temp, string Name1)
        {
            if (String.Compare(record.Name, Name1, true) == 0 &&
                            DateTime.ParseExact(record.Date_IN, ("dd.MM.yyyy"), CultureInfo.InvariantCulture) == temp.DateIN.Date &&
                            DateTime.ParseExact(record.Date_OUT, ("dd.MM.yyyy"), CultureInfo.InvariantCulture) == temp.DateOUT.Date)
            {
                return true;
            }
            else return false;
        }
    }
}
