const f = (list) => {
  let sum = 0;
  const listLength = list.length
  for (let i = 0; i < listLength; i++) {
    const current = list[i]
    const next = i + 1 >= listLength ? list[0] : list[i + 1]
    if (current === next) {
      sum += next
    }
  }  
  return sum
}
