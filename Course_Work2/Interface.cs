using System.Collections.Generic;


namespace Course_Work2
{
    interface IRecord
    {
        string Gender { get; set; }
        string Date_IN { get; set; }
        string Date_OUT { get; set; }
        string Name { get; set; }
        string Amount_of_persons_reserved { get; set; }
    }

    interface IRoom
    {
        string Number { get; set; }
        string Amount_of_persons { get; set; }
        string Amount_of_rooms { get; set; }
        string Type { get; set; }
        string Price { get; set; }
        List <Record> Records {get;}

    }
}
