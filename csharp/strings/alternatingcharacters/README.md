# Alternating Characters

Problem <https://www.hackerrank.com/challenges/alternating-characters/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings>

Find the minimum number of required deletions to make a string of alternating characters.

## Initial approach

Given that there are only two possible characters in the string (A or B) the problem requires that you find any string of length > 1 that contains the same character.

An initial approach would be to start at the beginning of the string and note the current character.  

Move a pointer to the next character.  If the character is the same as the current character, then it will need to be deleted.

Once you find a character that is different than the current character, set that to the current character.  

Now continue the linear search as before.  Marking a character as deleted until you see a character that is different than the current.

This makes the solution a O(n) complexity since it requires that all characters be inspected.

## Regular Expressions

Another approach is to tokenize the string using a regular expression.  Specifically look for all instances of the letter that are greater than a length of 1.  This will result in all instances that require n-1 characters to be removed to ensure alternating characters.
