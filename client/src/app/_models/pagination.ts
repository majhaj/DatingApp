export interface Pagination {
    currentPage: number;
    itemsPerPage: number;
    totalItems: number;
    totalPages: number;
}

export class PaginatedResoult<T> {
    result?: T
    pagination?: Pagination;
}