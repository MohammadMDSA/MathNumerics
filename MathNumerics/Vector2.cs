using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathNumerics
{

	//
	// Summary:
	//     Represents a vector with two single-precision floating-point values.
	[Serializable]
	public struct Vector2 : IEquatable<Vector2>, IFormattable
	{
		//
		// Summary:
		//     The X component of the vector.
		public float X;
		//
		// Summary:
		//     The Y component of the vector.
		public float Y;

		//
		// Summary:
		//     Creates a new System.Numerics.Vector2 object whose two elements have the same
		//     value.
		//
		// Parameters:
		//   value:
		//     The value to assign to both elements.
		public Vector2(float value)
		{
			X = value;
			Y = value;
		}

		//
		// Summary:
		//     Creates a vector whose elements have the specified values.
		//
		// Parameters:
		//   x:
		//     The value to assign to the System.Numerics.Vector2.X field.
		//
		//   y:
		//     The value to assign to the System.Numerics.Vector2.Y field.
		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
		}

		//
		// Summary:
		//     Gets the vector (1,0).
		//
		// Returns:
		//     The vector (1,0).
		public static Vector2 UnitX { get => new Vector2(1f, 0f); }

		//
		// Summary:
		//     Gets a vector whose 2 elements are equal to one.
		//
		// Returns:
		//     A vector whose two elements are equal to one (that is, it returns the vector
		//     (1,1).
		public static Vector2 One { get; }

		//
		// Summary:
		//     Gets the vector (0,1).
		//
		// Returns:
		//     The vector (0,1).
		public static Vector2 UnitY { get => new Vector2(0f, 1f); }

		//
		// Summary:
		//     Returns a vector whose 2 elements are equal to zero.
		//
		// Returns:
		//     A vector whose two elements are equal to zero (that is, it returns the vector
		//     (0,0).
		public static Vector2 Zero { get => new Vector2(0f); }

		//
		// Summary:
		//     Returns a vector whose elements are the absolute values of each of the specified
		//     vector's elements.
		//
		// Parameters:
		//   value:
		//     A vector.
		//
		// Returns:
		//     The absolute value vector.
		public static Vector2 Abs(Vector2 value)
		{
			return new Vector2(
				value.X > 0 ? value.X : -value.X,
				value.Y > 0 ? value.Y : -value.Y
				);
		}

		//
		// Summary:
		//     Adds two vectors together.
		//
		// Parameters:
		//   left:
		//     The first vector to add.
		//
		//   right:
		//     The second vector to add.
		//
		// Returns:
		//     The summed vector.
		public static Vector2 Add(Vector2 left, Vector2 right)
		{
			return new Vector2(left.X + right.X, left.Y + right.Y);
		}

		//
		// Summary:
		//     Restricts a vector between a minimum and a maximum value.
		//
		// Parameters:
		//   value1:
		//     The vector to restrict.
		//
		//   min:
		//     The minimum value.
		//
		//   max:
		//     The maximum value.
		//
		// Returns:
		//     The restricted vector.
		public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
		{
			float x = value1.X;
			if(value1.X < min.X)
				x = min.X;
			else if(value1.X > max.X)
				x = max.X;


			float y = value1.Y;
			if (value1.Y < min.Y)
				y = min.Y;
			else if (value1.Y > max.Y)
				y = max.Y;

			return new Vector2(x, y);
		}

		//
		// Summary:
		//     Returns the Euclidean distance squared between two specified points.
		//
		// Parameters:
		//   value1:
		//     The first point.
		//
		//   value2:
		//     The second point.
		//
		// Returns:
		//     The distance squared.
		public static float DistanceSquared(Vector2 value1, Vector2 value2);
		//
		// Summary:
		//     Divides the first vector by the second.
		//
		// Parameters:
		//   left:
		//     The first vector.
		//
		//   right:
		//     The second vector.
		//
		// Returns:
		//     The vector resulting from the division.
		public static Vector2 Divide(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Divides the specified vector by a specified scalar value.
		//
		// Parameters:
		//   left:
		//     The vector.
		//
		//   divisor:
		//     The scalar value.
		//
		// Returns:
		//     The vector that results from the division.
		public static Vector2 Divide(Vector2 left, float divisor);
		//
		// Summary:
		//     Returns the dot product of two vectors.
		//
		// Parameters:
		//   value1:
		//     The first vector.
		//
		//   value2:
		//     The second vector.
		//
		// Returns:
		//     The dot product.
		public static float Dot(Vector2 value1, Vector2 value2);
		//
		// Summary:
		//     Performs a linear interpolation between two vectors based on the given weighting.
		//
		// Parameters:
		//   value1:
		//     The first vector.
		//
		//   value2:
		//     The second vector.
		//
		//   amount:
		//     A value between 0 and 1 that indicates the weight of value2.
		//
		// Returns:
		//     The interpolated vector.
		public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount);
		//
		// Summary:
		//     Returns a vector whose elements are the maximum of each of the pairs of elements
		//     in two specified vectors.
		//
		// Parameters:
		//   value1:
		//     The first vector.
		//
		//   value2:
		//     The second vector.
		//
		// Returns:
		//     The maximized vector.
		public static Vector2 Max(Vector2 value1, Vector2 value2);
		//
		// Summary:
		//     Returns a vector whose elements are the minimum of each of the pairs of elements
		//     in two specified vectors.
		//
		// Parameters:
		//   value1:
		//     The first vector.
		//
		//   value2:
		//     The second vector.
		//
		// Returns:
		//     The minimized vector.
		public static Vector2 Min(Vector2 value1, Vector2 value2);
		//
		// Summary:
		//     Multiplies a scalar value by a specified vector.
		//
		// Parameters:
		//   left:
		//     The scaled value.
		//
		//   right:
		//     The vector.
		//
		// Returns:
		//     The scaled vector.
		public static Vector2 Multiply(float left, Vector2 right);
		//
		// Summary:
		//     Multiplies a vector by a specified scalar.
		//
		// Parameters:
		//   left:
		//     The vector to multiply.
		//
		//   right:
		//     The scalar value.
		//
		// Returns:
		//     The scaled vector.
		public static Vector2 Multiply(Vector2 left, float right);
		//
		// Summary:
		//     Multiplies two vectors together.
		//
		// Parameters:
		//   left:
		//     The first vector.
		//
		//   right:
		//     The second vector.
		//
		// Returns:
		//     The product vector.
		public static Vector2 Multiply(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Negates a specified vector.
		//
		// Parameters:
		//   value:
		//     The vector to negate.
		//
		// Returns:
		//     The negated vector.
		public static Vector2 Negate(Vector2 value);
		//
		// Summary:
		//     Returns a vector with the same direction as the specified vector, but with a
		//     length of one.
		//
		// Parameters:
		//   value:
		//     The vector to normalize.
		//
		// Returns:
		//     The normalized vector.
		public static Vector2 Normalize(Vector2 value);
		//
		// Summary:
		//     Returns the reflection of a vector off a surface that has the specified normal.
		//
		// Parameters:
		//   vector:
		//     The source vector.
		//
		//   normal:
		//     The normal of the surface being reflected off.
		//
		// Returns:
		//     The reflected vector.
		public static Vector2 Reflect(Vector2 vector, Vector2 normal);
		//
		// Summary:
		//     Returns a vector whose elements are the square root of each of a specified vector's
		//     elements.
		//
		// Parameters:
		//   value:
		//     A vector.
		//
		// Returns:
		//     The square root vector.
		public static Vector2 SquareRoot(Vector2 value);
		//
		// Summary:
		//     Subtracts the second vector from the first.
		//
		// Parameters:
		//   left:
		//     The first vector.
		//
		//   right:
		//     The second vector.
		//
		// Returns:
		//     The difference vector.
		public static Vector2 Subtract(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Transforms a vector by the specified Quaternion rotation value.
		//
		// Parameters:
		//   value:
		//     The vector to rotate.
		//
		//   rotation:
		//     The rotation to apply.
		//
		// Returns:
		//     The transformed vector.
		public static Vector2 Transform(Vector2 value, Quaternion rotation);
		//
		// Summary:
		//     Transforms a vector by a specified 4x4 matrix.
		//
		// Parameters:
		//   position:
		//     The vector to transform.
		//
		//   matrix:
		//     The transformation matrix.
		//
		// Returns:
		//     The transformed vector.
		public static Vector2 Transform(Vector2 position, Matrix4x4 matrix);
		//
		// Summary:
		//     Transforms a vector by a specified 3x2 matrix.
		//
		// Parameters:
		//   position:
		//     The vector to transform.
		//
		//   matrix:
		//     The transformation matrix.
		//
		// Returns:
		//     The transformed vector.
		public static Vector2 Transform(Vector2 position, Matrix3x2 matrix);
		//
		// Summary:
		//     Transforms a vector normal by the given 3x2 matrix.
		//
		// Parameters:
		//   normal:
		//     The source vector.
		//
		//   matrix:
		//     The matrix.
		//
		// Returns:
		//     The transformed vector.
		public static Vector2 TransformNormal(Vector2 normal, Matrix3x2 matrix);
		//
		// Summary:
		//     Transforms a vector normal by the given 4x4 matrix.
		//
		// Parameters:
		//   normal:
		//     The source vector.
		//
		//   matrix:
		//     The matrix.
		//
		// Returns:
		//     The transformed vector.
		public static Vector2 TransformNormal(Vector2 normal, Matrix4x4 matrix);
		//
		// Summary:
		//     Copies the elements of the vector to a specified array starting at a specified
		//     index position.
		//
		// Parameters:
		//   array:
		//     The destination array.
		//
		//   index:
		//     The index at which to copy the first element of the vector.
		//
		// Exceptions:
		//   T:System.ArgumentNullException:
		//     array is null.
		//
		//   T:System.ArgumentException:
		//     The number of elements in the current instance is greater than in the array.
		//
		//   T:System.ArgumentOutOfRangeException:
		//     index is less than zero. -or- index is greater than or equal to the array length.
		//
		//   T:System.RankException:
		//     array is multidimensional.
		public void CopyTo(float[] array, int index);
		//
		// Summary:
		//     Copies the elements of the vector to a specified array.
		//
		// Parameters:
		//   array:
		//     The destination array.
		//
		// Exceptions:
		//   T:System.ArgumentNullException:
		//     array is null.
		//
		//   T:System.ArgumentException:
		//     The number of elements in the current instance is greater than in the array.
		//
		//   T:System.RankException:
		//     array is multidimensional.
		public void CopyTo(float[] array);
		//
		// Summary:
		//     Returns a value that indicates whether this instance and another vector are equal.
		//
		// Parameters:
		//   other:
		//     The other vector.
		//
		// Returns:
		//     true if the two vectors are equal; otherwise, false.
		public bool Equals(Vector2 other);
		//
		// Summary:
		//     Returns a value that indicates whether this instance and a specified object are
		//     equal.
		//
		// Parameters:
		//   obj:
		//     The object to compare with the current instance.
		//
		// Returns:
		//     true if the current instance and obj are equal; otherwise, false```. If <code>obj</code>
		//     isnull, the method returnsfalse`.
		public override bool Equals(object obj);
		//
		// Summary:
		//     Returns the hash code for this instance.
		//
		// Returns:
		//     The hash code.
		public override int GetHashCode();
		//
		// Summary:
		//     Returns the length of the vector.
		//
		// Returns:
		//     The vector's length.
		public float Length();
		//
		// Summary:
		//     Returns the length of the vector squared.
		//
		// Returns:
		//     The vector's length squared.
		public float LengthSquared();
		//
		// Summary:
		//     Returns the string representation of the current instance using the specified
		//     format string to format individual elements and the specified format provider
		//     to define culture-specific formatting.
		//
		// Parameters:
		//   format:
		//     A or that defines the format of individual elements.
		//
		//   formatProvider:
		//     A format provider that supplies culture-specific formatting information.
		//
		// Returns:
		//     The string representation of the current instance.
		public string ToString(string format, IFormatProvider formatProvider);
		//
		// Summary:
		//     Returns the string representation of the current instance using default formatting.
		//
		// Returns:
		//     The string representation of the current instance.
		public override string ToString();
		//
		// Summary:
		//     Returns the string representation of the current instance using the specified
		//     format string to format individual elements.
		//
		// Parameters:
		//   format:
		//     A or that defines the format of individual elements.
		//
		// Returns:
		//     The string representation of the current instance.
		public string ToString(string format);

		//
		// Summary:
		//     Adds two vectors together.
		//
		// Parameters:
		//   left:
		//     The first vector to add.
		//
		//   right:
		//     The second vector to add.
		//
		// Returns:
		//     The summed vector.
		public static Vector2 operator +(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Negates the specified vector.
		//
		// Parameters:
		//   value:
		//     The vector to negate.
		//
		// Returns:
		//     The negated vector.
		public static Vector2 operator -(Vector2 value);
		//
		// Summary:
		//     Subtracts the second vector from the first.
		//
		// Parameters:
		//   left:
		//     The first vector.
		//
		//   right:
		//     The second vector.
		//
		// Returns:
		//     The vector that results from subtracting right from left.
		public static Vector2 operator -(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Multiples the specified vector by the specified scalar value.
		//
		// Parameters:
		//   left:
		//     The vector.
		//
		//   right:
		//     The scalar value.
		//
		// Returns:
		//     The scaled vector.
		public static Vector2 operator *(Vector2 left, float right);
		//
		// Summary:
		//     Multiplies two vectors together.
		//
		// Parameters:
		//   left:
		//     The first vector.
		//
		//   right:
		//     The second vector.
		//
		// Returns:
		//     The product vector.
		public static Vector2 operator *(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Multiples the scalar value by the specified vector.
		//
		// Parameters:
		//   left:
		//     The vector.
		//
		//   right:
		//     The scalar value.
		//
		// Returns:
		//     The scaled vector.
		public static Vector2 operator *(float left, Vector2 right);
		//
		// Summary:
		//     Divides the first vector by the second.
		//
		// Parameters:
		//   left:
		//     The first vector.
		//
		//   right:
		//     The second vector.
		//
		// Returns:
		//     The vector that results from dividing left by right.
		public static Vector2 operator /(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Divides the specified vector by a specified scalar value.
		//
		// Parameters:
		//   value1:
		//     The vector.
		//
		//   value2:
		//     The scalar value.
		//
		// Returns:
		//     The result of the division.
		public static Vector2 operator /(Vector2 value1, float value2);
		//
		// Summary:
		//     Returns a value that indicates whether each pair of elements in two specified
		//     vectors is equal.
		//
		// Parameters:
		//   left:
		//     The first vector to compare.
		//
		//   right:
		//     The second vector to compare.
		//
		// Returns:
		//     true if left and right are equal; otherwise, false.
		public static bool operator ==(Vector2 left, Vector2 right);
		//
		// Summary:
		//     Returns a value that indicates whether two specified vectors are not equal.
		//
		// Parameters:
		//   left:
		//     The first vector to compare.
		//
		//   right:
		//     The second vector to compare.
		//
		// Returns:
		//     true if left and right are not equal; otherwise, false.
		public static bool operator !=(Vector2 left, Vector2 right);
	}
}
