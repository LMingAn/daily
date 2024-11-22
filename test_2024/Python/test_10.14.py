# t = (1, 2, 3, 4)
# p = (5, 6, 7, 8)

# # A
# L = t + p
# max_value = max(L)
# min_value = min(L)
# print("Merged tuple L:", L)
# print("Maximum value in L:", max_value)
# print("Minimum value in L:", min_value)

# # B
# L_list = list(L)
# del L_list[1]
# L_modified = tuple(L_list)
# print("Tuple L after deleting second element:", L_modified)

# # C
# L_slice = L[2:6]
# print("Elements from the 3rd to 6th in L:", L_slice)

# 2
S1 = {1, 2, 3, 4, 5, 6}
S2 = {3, 4, 5, 6, 7, 8}

# A
S = S1.union(S2)
S.add(20)
print("Set S after adding 20:", S)

# B
S.discard(5)
print("Set S after deleting 5:", S)

# C
intersection = S1.intersection(S2)
union = S1.union(S2)
difference = S1.difference(S2)
symmetric_difference = S1.symmetric_difference(S2)

print("Intersection of S1 and S2:", intersection)
print("Union of S1 and S2:", union)
print("Difference (S1 - S2):", difference)
print("Symmetric difference between S1 and S2:", symmetric_difference)
