using ClassLibrary.Base;
using System;

namespace ClassLibrary
{
    public class Pokemon : EntityBase
    {
        private String id;
        private String name;
        private String description;
        private String image;

        public Pokemon(String id, String name, String desc)
        {
            this.Id = id;
            this.Name = name;
            this.Image = this.Id + ".png";
            this.description = desc;
        }

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public String Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public String Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
