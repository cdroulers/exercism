export const transform = old => {
  const result = {};
  Object.keys(old).forEach(k => {
    old[k].forEach(x => {
      result[x.toLocaleLowerCase()] = parseInt(k);
    });
  });

  return result;
};
