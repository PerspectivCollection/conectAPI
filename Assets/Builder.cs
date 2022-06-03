using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//skrevet i java
// public class Builder {
//     private final String firstName; // required
//     private final String lastName; // required
//     private final int age; // optional

//     private Builder(BuilderBuilder builder) {
//         this.firstName = builder.firstName;
//         this.lastName = builder.lastName;
//         this.age = builder.age;
//     }

//     public static class BuilderBuilder {
//         private final String firstName;
//         private final String lastName;
//         private int age;

//         public BuilderBuilder(String firstName, String lastName) {
//             this.firstName = firstName;
//             this.lastName = lastName;
//         }

//         public BuilderBuilder age(int age) {
//             this.age = age;
//             return this;
//         }

//         public Builder build() {
//             return new Builder(this);
//         }

//     }
// }