using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace PeopleWithResearch
{
    /// <summary>
    /// Extended Entryclass which holds a name property
    /// </summary>
    public class ExtendedEntry : Entry
    {

        public string IDValue { get; set; }

        public string IDValueee { get; set; }

        public static readonly BindableProperty IDValueProperty = BindableProperty.Create(
                                                  propertyName: "IDValue",
                                                  returnType: typeof(string),
                                                    declaringType: typeof(ExtendedEntry),
                                                  defaultValue: "",
                                                  defaultBindingMode: BindingMode.TwoWay,
                                                  propertyChanged: IDPropertyChanged);



        public static readonly BindableProperty IDValueeeProperty = BindableProperty.Create(
                                                  propertyName: "IDValueee",
                                                  returnType: typeof(string),
                                                    declaringType: typeof(ExtendedEntry),
                                                  defaultValue: "",
                                                  defaultBindingMode: BindingMode.TwoWay,
                                                  propertyChanged: IDValueeePropertyChanged);

        private static void IDPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExtendedEntry)bindable;
            control.IDValue = newValue.ToString();
        }


        private static void IDValueeePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExtendedEntry)bindable;
            control.IDValueee = newValue.ToString();
        }
    }
}
