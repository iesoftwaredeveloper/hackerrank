# Sherlock and the Valid String

Problem: <https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings>

## Goal

The goal is to modify a string by remove zero or 1 instances of a character that results in the frequency of remaining characters to be the same.  The amount of the frequency can be any frequency as long as it is the same.

## Intial approach

In order to determine the result we must determine a few things.

1. The frequence of each character in the string.
2. The common frequency among all of the characters.
3. Is there one or more characters that has a frequence that is not equal to the common frequency?
4. If there are any characters that do not share the common frequency, then is it only 1 higher than the common frequency?

To track this we can create two dictionaries.  The first dictionary will contain a mapping of each character and the frequency of that character.

The second dictionary will contain a mapping of the frequency and the number of times that the frequency occurs.

## Edge cases

- The string is empty

## Gotchas

The current description of the problem, as of this writing, leads you to believe you can only remove a *single* instance of a *single* character to make the string valid.  The examples all support this as well.

However, you can remove a *single* instance of *any* number of characters.

This means that if you have two frequencies and the frequency is only 1 apart that you can then make it valid by removing 1 instance of each character that has the greater count.
