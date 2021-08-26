using System;

namespace Hackerrank
{
    public abstract class Option<T>
    {
        public abstract void Do(Action<T> action);

        public static Option<T> None() => new NoneOption();

        public static Option<T> Some(T item)
        {
            return new SomeOption(item);
        }

        public static implicit operator Option<T>(T value)
        {
            return new SomeOption(value);
        }

        public static implicit operator Option<T>(None _)
        {
            return new NoneOption();
        }

        public sealed class SomeOption : Option<T>
        {
            private T _value;

            public SomeOption(T value)
            {
                _value = value;
            }

            public override void Do(Action<T> action)
            {
                action(_value);
            }
        }
        public sealed class NoneOption : Option<T>
        {
            public override void Do(Action<T> action)
            {
                //
            }
        }
    }

    public sealed class None
    {
        public static None Value => new None();

        private None()
        {

        }
    }
}