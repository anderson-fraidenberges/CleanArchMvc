public abstract class EitherOr<L,R> {
    public static EitherOr<L, R> Left(L left) => new Left<L, R>(left);
    public static EitherOr<L, R> Right(R right) => new Right<L, R>(right);

    public abstract TResult Match<TResult>(Func<L, TResult> onLeft, Func<R, TResult> onRight);
}

public class Left<L,R>: EitherOr<L,R> {
    public L Value { get; }

    public Left(L value) {
        Value = value;
    }

    public override TResult Match<TResult>(Func<L, TResult> onLeft, Func<R, TResult> onRight) {
        return onLeft(Value);
    }
}

public class Right<L,R>: EitherOr<L,R> {
    public R Value { get; }

    public Right(R value) {
        Value = value;
    }

    public override TResult Match<TResult>(Func<L, TResult> onLeft, Func<R, TResult> onRight) {
        return onRight(Value);
    }
}