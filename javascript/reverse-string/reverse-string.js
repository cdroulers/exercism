export function reverseString(s) {
  const chars = s.split("");
  chars.reverse();
  return chars.join("");
};
